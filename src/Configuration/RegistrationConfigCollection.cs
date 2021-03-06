﻿using System.Configuration;
using LightIoC.Concrete;

namespace LightIoC.Configuration {
	public class RegistrationConfigCollection : ConfigurationElementCollection {
		/// <summary>
		/// Initializes a new instance of the <see cref="RegistrationConfigCollection"/> class.
		/// </summary>
		public RegistrationConfigCollection() {

		}

		/// <summary>
		/// Gets the name used to identify this collection of elements in the configuration file when overridden in a derived class.
		/// </summary>
		/// <returns>The name of the collection; otherwise, an empty string. The default is an empty string.</returns>
		protected override string ElementName {
			get {
				return Consts.RegisterElementName;
			}
		}

		/// <summary>
		/// Gets the element key for a specified configuration element when overridden in a derived class.
		/// </summary>
		/// <param name="element">The <see cref="T:System.Configuration.ConfigurationElement" /> to return the key for.</param>
		/// <returns>
		/// An <see cref="T:System.Object" /> that acts as the key for the specified <see cref="T:System.Configuration.ConfigurationElement" />.
		/// </returns>
		protected override object GetElementKey(ConfigurationElement element) {
			return ((RegistrationConfigElement)element).Name;
		}

		/// <summary>
		/// Gets the type of the <see cref="T:System.Configuration.ConfigurationElementCollection" />.
		/// </summary>
		/// <returns>The <see cref="T:System.Configuration.ConfigurationElementCollectionType" /> of this collection.</returns>
		public override ConfigurationElementCollectionType CollectionType {
			get {
				return ConfigurationElementCollectionType.BasicMap;
			}
		}

		/// <summary>
		/// When overridden in a derived class, creates a new <see cref="T:System.Configuration.ConfigurationElement" />.
		/// </summary>
		/// <returns>
		/// A new <see cref="T:System.Configuration.ConfigurationElement" />.
		/// </returns>
		protected override ConfigurationElement CreateNewElement() {
			return new RegistrationConfigElement();
		}

		/// <summary>
		/// Creates a new <see cref="T:System.Configuration.ConfigurationElement" /> when overridden in a derived class.
		/// </summary>
		/// <param name="elementName">The name of the <see cref="T:System.Configuration.ConfigurationElement" /> to create.</param>
		/// <returns>
		/// A new <see cref="T:System.Configuration.ConfigurationElement" />.
		/// </returns>
		protected override ConfigurationElement CreateNewElement(string elementName) {
			return new RegistrationConfigElement(elementName, string.Empty);
		}
	}


}
