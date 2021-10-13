﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
  public interface IUserRepository : IRepository<User>
  {
    void CreateDapper(User user);
    List<User> GetAllDapper();
  }
}
