using BookReadingEvent.Core.Domain.Repository;
using BookReadingEvent.ProductDomain.AppServices.DTOs;
using BookReadingEvent.ProductDomain.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookReadingEvent.ProductDomain.Repository
{
    public interface IUserRepository 
    {
        string AddUser(SignUpDTO user);
        bool LoginUser(LoginDTO item);
        string GetInvitedEventsString(string Email);
    }
}
