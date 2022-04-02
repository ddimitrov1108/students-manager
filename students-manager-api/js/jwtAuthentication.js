import jwt from 'jsonwebtoken'
import messageLogger from './messageLogger.js'

const signJwt = (tokenData) => {
    messageLogger('success', `Signed token for user: ${ tokenData.email }`);
    return jwt.sign({ data: { ...tokenData }}, process.env.SECRET_KEY, { expiresIn: '1d' });
}

const authenticateJwt = (req, res, next) => {
    const authHeader = req.headers['authorization'];
    const token = authHeader && authHeader.split(' ')[1];

    messageLogger('attempt', `Verifying token: ${ token }`);

    if(token == null) {
        messageLogger('warning', `Passed invalid token: ${ token }`);
        return res.status(400).json({ err: 'Invalid token' });
    }

    jwt.verify(token, process.env.SECRET_KEY, (err, user) => {
        if(err) {
            messageLogger('warning', `Failed to verify token: ${ token }`);
            return res.status(403).json({ err: 'Invalid token' });
        }
        
        req.user = user.data;
        messageLogger('success', `Token verified on: ${ req.user.email }`);
        next();
    });
}

export {
    signJwt,
    authenticateJwt,
}