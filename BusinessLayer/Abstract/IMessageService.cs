using EntityLayer.Concrete;
using FluentValidation.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IMessageService:IGenericService<Message>
    {
        List<Message> GetInboxListByWriter(string p);
    }
}
