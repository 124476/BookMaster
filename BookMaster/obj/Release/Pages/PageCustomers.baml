   M S B A M L   `   `   `  ���� E  ABookMaster, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:BookMaster.PagesBookMaster.Pages  $    BookMaster.Pages.PageCustomers   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     0localclr-namespace:BookMaster.Pages     -     N� Title$  PageCustomers��.���  � ColumnDefinitions �� �� $��3* �.+��� $��Center=�$��Center=�$	��150��.+��� $��Customer ID��$��17(��� -    ��Name$ PoiskCustomer��$��17(��� $
��Name��$��17(��� -   $ 	PoiskName��$��17(��� -    ��Name$ Search��$��17(�$��Search��
�������$��0,10,0,0q��� $��Bottom=�$��0,0,0,30q�$��Center=�$	��150�� �� Orientation$ 
Horizontal=�.+��� -   $
 Edit��
�������$��17(�$��Edit...��$��70���� -   $	 Add��
�������$��17(�$��Add...��$��70��$��10,0,0,0q�&   System.Windows.Controls.DataGrid  -     Name$ DataCustomers��$��17(�   AutoGenerateColumns .     
IsReadOnly . $��1��   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn	   Header$	 ID��1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 �� *IdC+  $
	 Name��
 �� *Name+  $	 Address��
 �� *	Address+  $		 Zip��
 �� *Zip+  $
	 City��
 �� *City+