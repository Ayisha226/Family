using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Service
{
    public interface IEmailService
    {
        bool SendEmail(EmailData emailData);
    }
}
