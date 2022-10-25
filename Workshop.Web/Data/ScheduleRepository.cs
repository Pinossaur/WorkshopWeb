﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Workshop.Web.Data.Entities;
using Workshop.Web.Models;

namespace Workshop.Web.Data
{
    public class ScheduleRepository : GenericRepository<Schedule>, IScheduleRepository
    {
        readonly DataContext _context;
        public ScheduleRepository (DataContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ScheduleModel>> GetAllWithCars (string userId)
        {
            return await _context.Schedules
                .Where(s => s.Car.User.Id == userId)
                .Select(s => new ScheduleModel
                {
                    Id = s.Id,
                    Description = s.Descripton,
                    StartDate = s.StartDate,
                    Price = s.Price,
                    Car = new CarModel
                    {
                        Id = s.Car.Id,
                        Brand = s.Car.Brand,
                        Model = s.Car.Model,
                        Year = s.Car.Year,
                    },
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<ScheduleModel>> GetAllWithCars()
        {
            return await _context.Schedules
                .Select(s => new ScheduleModel
                {
                    Id = s.Id,
                    Description = s.Descripton,
                    StartDate = s.StartDate,
                    Price = s.Price,
                    Car = new CarModel
                    {
                        Id = s.Car.Id,
                        Brand = s.Car.Brand,
                        Model = s.Car.Model,
                        Year = s.Car.Year,
                    },
                })
                .ToListAsync();
        }
    }
}
