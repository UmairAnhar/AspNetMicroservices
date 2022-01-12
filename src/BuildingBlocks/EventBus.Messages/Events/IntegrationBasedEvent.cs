using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBus.Messages.Events
{
    public class IntegrationBasedEvent
    {
        public IntegrationBasedEvent()
        {
            Id = Guid.NewGuid();
            CreatedDate = DateTime.Now;
        }
        public IntegrationBasedEvent(Guid id, DateTime createdDate)
        {
            Id = id;
            CreatedDate = createdDate;
        }
        public Guid Id { get; private set; }
        public DateTime CreatedDate { get; set; }
    }
}
