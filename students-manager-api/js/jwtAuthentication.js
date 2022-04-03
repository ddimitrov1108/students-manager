import jwt from 'jsonwebtoken'
import messageLogger from './messageLogger.js'

const signJwt = (tokenData) => {
    messageLogger(200, `Signed token for user: ${ tokenData.email }`);
    return jwt.sign({ data: { ...tokenData }}, process.env.SECRET_KEY, { expiresIn: '1d' });
}

const authenticateJwt = (req, res, next) => {
    const authHeader = req.headers['authorization'];
    const token = authHeader && authHeader.split(' ')[1];

    messageLogger(100, `Verifying token: ${ token }`);

    if(token == null) {
        messageLogger(400, `Passed invalid token: ${ token }`);
        return res.status(400).json({ err: 'Invalid token' });
    }

    jwt.verify(token, process.env.SECRET_KEY, (err, user) => {
        if(err) {
            messageLogger(400, `Failed to verify token: ${ token }`);
            return res.status(403).json({ err: 'Invalid token' });
        }
        
        req.user = user.data;
        messageLogger(200, `Token verified on: ${ req.user.email }`);
        next();
    });
}

export {
    signJwt,
    authenticateJwt,
}