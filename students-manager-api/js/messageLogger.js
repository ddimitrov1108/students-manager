export default function messageLogger (statusCode, messageToSend) {
    const timeOfExecution = new Date().toLocaleTimeString();
    let messagePrefix;

    switch(statusCode) {
        case 100:
            messagePrefix = `\x1b[44m INFO`; 
            break;
        case 200: 
            messagePrefix = `\x1b[42m SUCCESS`; 
            break;
        case 400:
            messagePrefix = `\x1b[43m\x1b[30m CLIENT-ERROR`; 
            break;
        case 500:
            messagePrefix = `\x1b[41m SERVER-ERROR`; 
            break;
        default: 
            messagePrefix = `\x1b[47m MESSAGE`; 
            break;
    }

    console.log(`\x1b[2m[${ timeOfExecution }]\x1b[0m ${ messagePrefix } \x1b[0m ${ messageToSend }`);
}