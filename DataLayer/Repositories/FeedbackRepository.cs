using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
	public class FeedbackRepository : GenericRepository<FeedBack>
	{
		public FeedbackRepository(SswdatabaseContext context) : base(context)
		{
		}
	}
}
