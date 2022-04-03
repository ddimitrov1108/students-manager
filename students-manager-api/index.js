import dotenv from 'dotenv'
import express from 'express'
import bcrypt from 'bcrypt'
import bodyParser from 'body-parser'
import messageLogger from './js/messageLogger.js'
import DatabaseConnection from './js/DatabaseConnection.js'
import { sqlUsers, sqlEdu, sqlStudents } from './js/sqlCommands.js'
import {signJwt, authenticateJwt } from './js/jwtAuthentication.js'
import {
    registerFormMiddleware,
    loginFormMiddleware,
    studentFormMiddleware,
    facultyNumberParamMiddleware,
} from './js/middleware.js'

messageLogger(100, process.env.API_NAME);
messageLogger(100, process.env.DB_CONNECTOR_NAME);

dotenv.config();
const app = express();
app.use(bodyParser.urlencoded({ extended: false }));
app.use(bodyParser.json());

const db = new DatabaseConnection(
    process.env.DATABASE_HOST,
    process.env.DATABASE_USER,
    process.env.DATABASE_PASSWORD,
    process.env.DATABASE_NAME
);

app.get('/users/get', authenticateJwt, (req, res) => {
    const { id, fullName, email } = req.user;
    messageLogger(200, `${ req.route.path } from ${ email }`);
    res.status(200).json({ id, fullName, email });
})

app.post('/users/login', loginFormMiddleware, (req, res) => {
    const { email, password } = req.body;

    db.executeQuery(sqlUsers.getByEmail,[email], (rows) => {

        if(rows[0] != undefined) {
            const { password: hashedPassword } = rows[0];

            bcrypt.compare(password, hashedPassword, (err, same) => {
                if(err) {
                    messageLogger(500, err.stack);
                    res.status(500).json({ err: 'Internal server problem' });
                    throw err;
                }
                else if(same) {
                    const { id, firstName, lastName, email } = rows[0];
                    messageLogger(200, `Login Authorized: ${ email }`);
                    
                    res.status(200).json({ 
                        jwt: signJwt({
                            id,
                            fullName: `${ firstName } ${ lastName }`,
                            email,
                        }) 
                    });
                }
                else {
                    messageLogger(400, 'Email address or Password is incorrect');
                    res.status(400).json({ err: 'Email address or Password is incorrect' });
                }
            })
        }
    })
})

app.get('/students/get/all', authenticateJwt, (req, res) => {
    db.executeQuery(sqlStudents.getAll, [], (rows) => res.status(200).json([...rows]));
})

app.get('/students/get/:facultyNumber', authenticateJwt, facultyNumberParamMiddleware, (req, res) => {
    db.executeQuery(sqlStudents.getByFacultyNumber, [req.params.facultyNumber], (rows) => res.status(200).json([...rows]));
})

app.post('/students/create/:facultyNumber', authenticateJwt, facultyNumberParamMiddleware, studentFormMiddleware, (req, res) => {
    db.executeQuery(
        sqlStudents.getByFacultyNumber, 
        [req.params.facultyNumber],
        (rows) => {
            if(rows.length == 0) {
                db.executeQuery(
                    sqlStudents.create,
                    [
                        req.params.facultyNumber,
                        req.body.firstName, 
                        req.body.lastName, 
                        req.body.phoneNumber, 
                        req.body.eduDegreeTypeId, 
                        req.body.eduSpecialtyId, 
                        req.body.eduFormId, 
                        req.body.eduYear, 
                        req.body.eduGpa, 
                        req.body.eduPaused 
                    ],
                    (rows) => {
                        if(rows.insertId) {
                            messageLogger(200, `New student created at: [${ rows.insertId }]: ${ req.params.facultyNumber }`);
                            res.status(201).json({});
                        }
                        else
                            res.status(400).json({ err: 'Failed to update' });
                    }
                )
            }             
            else {
                messageLogger(400, 'Student with this faculty number already exists');
                res.status(403).json({ err: 'Student with this faculty number already exists'});
            }
        }
    );
})

app.post('/students/update/:facultyNumber', authenticateJwt, facultyNumberParamMiddleware, studentFormMiddleware, (req, res) => {
    db.executeQuery(
        sqlStudents.update,
        [
            req.body.firstName, 
            req.body.lastName, 
            req.body.phoneNumber, 
            req.body.eduDegreeTypeId, 
            req.body.eduSpecialtyId, 
            req.body.eduFormId, 
            req.body.eduYear, 
            req.body.eduGpa, 
            req.body.eduPaused,
            req.params.facultyNumber
        ],
        (rows) => {
            if(rows.affectedRows) {
                messageLogger(200, `Student update at: ${ req.params.facultyNumber }`);
                res.status(201).json({});
            }
            else
                res.status(400).json({ err: 'Failed to update' });
        }
    )
})

app.delete('/students/delete/:facultyNumber', authenticateJwt, facultyNumberParamMiddleware, (req, res) => {
    db.executeQuery(
        sqlStudents.delete, 
        [req.params.facultyNumber],
        (rows) => {
            if(rows.affectedRows)
                res.status(200).json({});
            else
                res.status(400).json({ err: 'Failed to update' });
        }
    )
})

app.get('/edu/get/degree-types', authenticateJwt, (req, res) => { 
    db.executeQuery(sqlEdu.getDegreeTypes, [], (rows) => res.status(200).json([...rows]))
})

app.get('/edu/get/specialties', authenticateJwt, (req, res) => {
    db.executeQuery(sqlEdu.getSpecialties, [], (rows) => res.status(200).json([...rows]))
})

app.get('/edu/get/forms', authenticateJwt, (req, res) => {
    db.executeQuery(sqlEdu.getForms, [], (rows) => res.status(200).json([...rows]))
})

app.listen(process.env.PORT, () => {
    messageLogger(200, `StudentsManagerAPI running on http://${ process.env.DATABASE_HOST }:${ process.env.PORT }`);
})