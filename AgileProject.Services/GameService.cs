﻿using AgileProject.Data;
using AgileProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileProject.Services
{
    public class GameService
    {
        private readonly Guid _userId;

        public GameService(Guid userId)
        {
            _userId = userId;
        }

        public CreateGame(GameCreate model)
        {
            var entity = new Game()
            {
                Name = model.Name,
                Description = model.Description,
                Price = model.Price,
            };
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
            }
        }
    }
}
