﻿using CleanArch.Domain.Entities;
using CleanArch.Domain.Repositories;
using CleanArch.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Persistence.Repositories;

public class BaseReadRepository<T> : IBaseReadRepository<T> where T : BaseEntity
{
	private readonly DbSet<T> _table;

	public BaseReadRepository(AppDbContext context)
	{
		_table = context.Set<T>();
	}

	public async Task<List<T>> GetAllAsync()
	{
		return await _table.ToListAsync();
	}

	public async Task<T> GetAsync(int id)
	{
		return await _table.FindAsync(id);
	}
}
