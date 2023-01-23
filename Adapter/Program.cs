using ChainOfResponsibility.Pattern;

var logger = new Logger();

var loggableObj = new LoggableObject();

var nonLoggableObj = new NonLoggableObject
{
    Id = 12,
    Value = "NonLoggableObject"
};
var adaptedNonLoggableObj = new NonLoggableObjectAdapter(nonLoggableObj);

logger.LogToConsole(loggableObj);
logger.LogToConsole(adaptedNonLoggableObj);