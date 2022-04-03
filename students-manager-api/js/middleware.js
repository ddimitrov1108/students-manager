import dotenv from 'dotenv'
dotenv.config();
import messageLogger from './messageLogger.js'

const emailRegex = /^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
const passwordRegex = /^[a-zA-Z0-9!@#$&()\\-`.+,/\"]{8,}$/;
const facultyNumberRegex = /^[0-9]{1,10}$/;

const registerFormMiddleware = (req, res, next) => {
    if(!req.body.firstName || !req.body.lastName || !req.body.email || !req.body.password || !req.body.isAdmin || 
        (!emailRegex.test(req.body.email) || !passwordRegex.test(req.body.password))) 
    {
        consoleMessage(400, 'Bad body request');
        return res.status(400).json({ err: 'Bad body request' });
    }

    messageLogger(200, `Validated register form[${ req.body.email }]`);
    next();
}

const loginFormMiddleware = (req, res, next) => {

    if(!req.body.email || !req.body.password || 
        (!emailRegex.test(req.body.email) || !passwordRegex.test(req.body.password)))
    {
        messageLogger(400, 'Bad body request');
        return res.status(400).json({ err: 'Bad request' });
    }

        messageLogger(200, `Validated login form[${ req.body.email }]`);
        next();
}

const studentFormMiddleware = (req, res, next) => {
    if(
        !req.body.firstName || !req.body.lastName || !req.body.phoneNumber || 
        !req.body.eduDegreeTypeId || !req.body.eduSpecialtyId || !req.body.eduFormId ||
        !req.body.eduYear || !req.body.eduGpa || !req.body.eduPaused
    ) {
        messageLogger(400, 'Bad body request');
        return res.status(400).json({ err: 'Bad request' });
    }

    next();
}

const facultyNumberParamMiddleware = (req, res, next) => {
    if(!req.params.facultyNumber || !facultyNumberRegex.test(req.params.facultyNumber)) {
        messageLogger(400, 'Bad body request');
        return res.status(400).json({ err: 'Bad request' });
    }

    messageLogger(200, `Validated id[${ req.params.facultyNumber }]`);
    next();
}

export {
    registerFormMiddleware,
    loginFormMiddleware,
    studentFormMiddleware,
    facultyNumberParamMiddleware,
}