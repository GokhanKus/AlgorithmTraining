
namespace GreedyAlgorithm
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// orn 478$ para birimlerine bol para birimleri 100, 50, 20, 10, 5, 1 ve output olarak;
			// 100 - 4, 50 - 1, 20 - 1, 5 - 1, 1 - 3
			int money = 478;
			int[] currencies = { 100, 50, 20, 10, 5, 1 };

			var list = Calculate(money, currencies);

			foreach (var currencyCount in list)
			{
				Console.WriteLine($"{currencyCount}");
			}
		}

		static Dictionary<int, int> Calculate(int money, int[] currencies)
		{
			Dictionary<int, int> moneyList = new Dictionary<int, int>();
			for (int i = 0; i < currencies.Length; i++)
			{
				while (money >= currencies[i])
				{
					if (moneyList.ContainsKey(currencies[i]))
						moneyList[currencies[i]]++;

					else
						moneyList.Add(currencies[i], 1);

					money -= currencies[i];
				}
			}
			return moneyList;
		}

	}
}
