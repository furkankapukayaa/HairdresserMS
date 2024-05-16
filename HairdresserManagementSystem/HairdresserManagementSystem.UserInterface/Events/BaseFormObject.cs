using HairdresserManagementSystem.DataAccess.Context;

namespace HairdresserManagementSystem.UserInterface.Events
{
    public class BaseFormObject
    {
        public HairdresserMSContext hairdresserMSContext = new HairdresserMSContext();
        public Thread? thread;
    }
}