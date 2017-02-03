using System.Configuration;
using LightIoC.Concrete;

namespace LightIoC.Configuration {
	public class MappingConfigSection : ConfigurationSection {
		/// <summary>
		/// Initializes a new instance of the <see cref="MappingConfigSection"/> class.
		/// </summary>
		public MappingConfigSection() {

		}

		/// <summary>
		/// Gets the registrations.
		/// </summary>
		/// <value>
		/// The registrations.
		/// </value>
		[ConfigurationProperty(Consts.MappingsPropertyName, IsDefaultCollection = true)]
		[ConfigurationCollection(typeof(MappingConfigCollection), AddItemName = Consts.MapElementName)]
		public MappingConfigSection Registrations {
			get {
				return this[Consts.MappingsPropertyName] as MappingConfigSection;
			}
		}
	}
}
