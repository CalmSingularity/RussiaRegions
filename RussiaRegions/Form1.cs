using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace RussiaRegions
{
	public struct FederalDistrict
	{
		public string Name { get; set; }
		public string Capital { get; set; }
		public Dictionary<string, string> Regions { get; set; }  // <string> name of a region and <string> its center

		public FederalDistrict(string name, string capital)
		{
			Name = name;
			Capital = capital;
			Regions = new Dictionary<string, string>();
		}

		public override string ToString()
		{
			return Name;
		}
	}

	public partial class MainForm : Form
	{
		Dictionary<string, FederalDistrict> _fedDistricts;

		public MainForm()
		{
			InitializeComponent();

			// To store all federal districts and their regions:
			_fedDistricts = new Dictionary<string, FederalDistrict>();  // <string> for federal district name == FederalDistrict.Name

			try  // Read all federal discricts and regions from an XML file
			{
				XmlDocument document = new XmlDocument();
				document.Load(@"..\..\RussiaRegionalStructure.xml");

				if (document.DocumentElement.Name == "RussiaRegionalStructure" && document.DocumentElement.HasChildNodes)
				{
					foreach (XmlNode fedDistrictNode in document.DocumentElement.ChildNodes)
					{
						if (fedDistrictNode.Name == "FederalDistrict" && fedDistrictNode.Attributes != null)
						{
							string districtName = null, capital = null;
							foreach (XmlAttribute fedDistrictNodeAttribute in fedDistrictNode.Attributes)
							{
								if (fedDistrictNodeAttribute.Name == "Name")
									districtName = fedDistrictNodeAttribute.Value;
								if (fedDistrictNodeAttribute.Name == "Capital")
									capital = fedDistrictNodeAttribute.Value;
							}
							if (districtName != null && capital != null)
							{
								_fedDistricts[districtName] = new FederalDistrict(districtName, capital);

								if (fedDistrictNode.HasChildNodes)
								{
									foreach (XmlNode regionNode in fedDistrictNode.ChildNodes)
									{
										if (regionNode.Name == "Region" && regionNode.Attributes != null)
										{
											string regionName = null, center = null;
											foreach (XmlAttribute regionNodeAttribute in regionNode.Attributes)
											{
												if (regionNodeAttribute.Name == "Name")
													regionName = regionNodeAttribute.Value;
												if (regionNodeAttribute.Name == "Center")
													center = regionNodeAttribute.Value;
											}
											if (regionName != null && center != null)
											{
												_fedDistricts[districtName].Regions.Add(regionName, center);
											}
										}
									}
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}

			cbFedDistrict.DataSource = new BindingSource(_fedDistricts.Keys, null);  // populate Federal District ComboBox
		}

		private void cbFedDistrict_TextChanged(object sender, EventArgs e)
		{
			tbCapital.Text = _fedDistricts[cbFedDistrict.Text].Capital;  // show the capital of a federal district
			cbRegion.DataSource = new BindingSource(_fedDistricts[cbFedDistrict.Text].Regions.Keys, null);  // populate Region ComboBox
		}

		private void cbRegion_TextChanged(object sender, EventArgs e)
		{
			tbRegionalCenter.Text = _fedDistricts[cbFedDistrict.Text].Regions[cbRegion.Text];  // show the center of a region
		}
	}
}
