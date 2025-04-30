using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer
{
	public interface ICollectible
	{
		//Void functions that will be used by items
		void OnCollect(Player player);
		int Use(Player player, Monster monster);

	}

}