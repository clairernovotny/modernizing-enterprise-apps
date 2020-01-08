// ******************************************************************

using System;
using GalaSoft.MvvmLight.Messaging;

namespace ContosoExpenses.Messages
{
    public class SelectedDateMessage : MessageBase
    {
        public DateTime SelectedDate { get; set; }

        public SelectedDateMessage(DateTime selectedDate)
        {
            this.SelectedDate = selectedDate;
        }
    }
}