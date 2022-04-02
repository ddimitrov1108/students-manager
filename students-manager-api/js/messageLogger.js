const messageLogger = (statusCode, messageToSend) => {
    const timeOfExecution = new Date().toLocaleTimeString();
    let formatedMessage;

    switch(statusCode) {
        case 'success': 
            formatedMessage = `\x1b[42m SUCCESS \x1b[0m${ messageToSend }`; 
            break;
        case 'err': 
            formatedMessage = `\x1b[41m ERROR \x1b[0m${ messageToSend }`; 
            break;
        case 'warning': 
            formatedMessage = `\x1b[43m\x1b[30m WARNING \x1b[0m${ messageToSend }`; 
            break;
        case 'attempt': 
            formatedMessage = `\x1b[44m ATTEMPT \x1b[0m${ messageToSend }...`; 
            break;
        default: 
            formatedMessage = `\x1b[47m MESSAGE \x1b[0m${ messageToSend }`; 
            break;
    }

    console.log(`\x1b[2m[${ timeOfExecution }]\x1b[0m${ formatedMessage }`);
}

export default messageLogger;