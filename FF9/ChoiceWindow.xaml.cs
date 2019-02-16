using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FF9
{
    /// <summary>
    /// ChoiceWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class ChoiceWindow : Window
    {
		public enum eType
		{
			eItem,
			eCard,
		};

		public uint ID { get; set; }
		public eType Type { get; set; }

		public ChoiceWindow()
        {
            InitializeComponent();
        }

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			CreateItemList("");
		}

		private void TextBoxFilter_TextChanged(object sender, TextChangedEventArgs e)
		{
			CreateItemList(TextBoxFilter.Text);
		}

		private void ListBoxItem_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			ButtonDecision.IsEnabled = ListBoxItem.SelectedIndex >= 0;
		}

		private void ButtonDecision_Click(object sender, RoutedEventArgs e)
		{
			var item = (KeyValuePair<uint, String>)ListBoxItem.SelectedItem;
			ID = item.Key;
			Close();
		}

		private void CreateItemList(String filter)
		{
			ListBoxItem.Items.Clear();
			Dictionary<uint, String> items = AppInfo.Info.Items;
			if (Type == eType.eCard) items = AppInfo.Info.Cards;

			foreach (var item in items)
			{
				if (String.IsNullOrEmpty(filter) || item.Value.IndexOf(filter) >= 0)
				{
					ListBoxItem.Items.Add(item);
				}
			}
		}
	}
}
