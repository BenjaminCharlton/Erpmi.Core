﻿using System.Threading.Tasks;

namespace Erpmi.Core.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
