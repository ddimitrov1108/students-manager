import mysql from 'mysql'
import messageLogger from './messageLogger.js'

export default class DatabaseConnection {
    constructor(dbHost, dbUser, dbPwd, dbName) {
        this.connection = mysql.createConnection({
            host: dbHost,
            user: dbUser,
            password: dbPwd,
            database: dbName,
        })

        this.openConnection();
    }
    
    closeConnection = () => this.connection.end();

    openConnection() {
        this.connection.connect((err) => {
            if(err) {
                messageLogger('err', err.toString());
                return;
            }

            messageLogger('success', 'Connected to Database');

            setInterval(() => {
                this.connection.ping((error) => {
                    if(err) {
                        messageLogger('err', `Cant establish connection to database: ${ process.env.DATABASE_NAME }`);
                        messageLogger('err', err.stack);
                        throw err;
                    }
                })
            }, 1000 * 60);
        })
    }

    executeQuery(queryToExecute, queryParams, callback) {
        this.connection.query(
            queryToExecute,
            queryParams,
            (err, rows, fields)  => {
                if(err) {
                    messageLogger('err', err.stack);
                    throw err;
                }

                callback(rows);
            }
        )
    }
}