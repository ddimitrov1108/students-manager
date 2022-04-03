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
                messageLogger(500, err.stack);
                return;
            }
            
            messageLogger(200, `Connected to Database on thread#${ this.connection.threadId }`);
            setInterval(() => this.ping(), 1000 * 60);
        })
    }

    executeQuery(queryToExecute, queryParams, callback) {
        this.connection.query(
            queryToExecute,
            queryParams,
            (err, rows, fields)  => {
                if(err) {
                    messageLogger(500, `Query execution error: ${ err.stack }`);
                    throw err;
                }

                callback(rows);
            }
        )
    }

    ping() {
        this.connection.ping((err) => {
            if(err) {
                messageLogger(500, `Cant establish connection to database: ${ process.env.DATABASE_NAME }`);
                messageLogger(500, err.stack);
                throw err;
            }
        })
    }
}