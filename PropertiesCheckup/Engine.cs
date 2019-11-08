using System;
using System.Collections;
using System.Reflection;

namespace PropertiesCheckup
{
	public class Engine
	{
		public void Test()
		{
			var model = new Mock().GenerateModel();

			try
			{
				var props = model.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
				foreach (var prop in props)
				{
					object value = prop.GetValue(model);
					if (value is IList)
					{
						var itens = (IList)value;
						foreach (var item in itens)
						{
							var propsDoItem = item.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);

							foreach (var atributo in propsDoItem)
							{
								object internalvalue = atributo.GetValue(item);

								Console.WriteLine("    => {0} -> {1}", atributo.Name, internalvalue);
							}
						}
					}
					else
					{
						Console.WriteLine("{0} -> {1}", prop.Name, value);
					}
				}
			}
			catch
			{
				Console.WriteLine("Ops!");
			}
			Console.ReadKey();
		}
	}
}
