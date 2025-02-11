﻿using RentACarProject.Core.Entities.Concrete;

namespace RentACarProject.Business.Abstract
{
    public interface IUserService
    {
        List<OperationClaim> GetClaims(User user);
        void Add(User user);
        User GetByMail(string email);
    }
}
