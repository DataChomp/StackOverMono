﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StackOverFaux.Data.Model;

namespace StackOverFaux.Data.Abstract
{
	public interface IBadgeRepository
	{
		IEnumerable<dynamic> GetAllBadges();
		IEnumerable<dynamic> GetBadgesByUserID(int userid);
		IEnumerable<dynamic> GetAllBadgeCounts();

		//IEnumerable<Badge> GetAllBadges();
		//IQueryable<Badge> GetAllBadges();
		//IEnumerable<Badge> GetBadgesByUserId(int userid);
	}
}
