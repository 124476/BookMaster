   M S B A M L   `   `   `  ���� E  ABookMaster, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:BookMaster.PagesBookMaster.Pages  &     BookMaster.Pages.PageCirculation   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     0localclr-namespace:BookMaster.Pages     -     N� Title$  PageCirculation��.���  � ColumnDefinitions �� �� $��2* �.+��  � RowDefinitions �� �� �� .+��� $��\Impots\Logo.png���� $��1��$��Center=�.+��� $��Customer ID��$��17(�$��0,0,0,10q��� -    ��Name$ PoiskCustomer��$��17(�$	��200��$��0,0,0,10q��� -    ��Name$ Circulation��$��Circulation��$��17(�$	��200��$��Right=�$��0,5,0,0q�
��������� $��2��.+��� $��21(����� *Name+�� $��21(����� *IdC+�� $��17(�$��0,20,0,0q����� *	Address+��  �� Orientation$ 
Horizontal=�.+��� $��17(����� *Zip+�� $��17(����� *City+�� -   $
 Edit��$��Edit...��
�������$	��100��$��17(�$��Right=�$��0,5,10,0q�{�.  � $��1�� �� �� �� .+��  �� $��2* ��� .+��� .+��� $��Issue / Return��$��27(�$��Center=��� $ 
Horizontal=�.+��� $��Book ID��$��17(�$��80���� -   $��	PoiskBook��$��17(�$��10,0,0,0q�$	��200���� $ 
Horizontal=�.+��� $�� ��$��17(�$��80���� -   $��
SearchBook��$��17(�$��10,0,0,0q�$	��200���� $	��150��$��Center=�$��Center=�$��1��.+��� -   $��IssueBtn��$��Issue��$��17(�
�������{�.  �� -   $��	ReturnBtn��$��Return��$��17(�
�������{�.  �� $��1��.+��� $��Current Issues��$��23(�&   System.Windows.Controls.DataGrid  -	   $��
DataIssues��   AutoGenerateColumns .     
IsReadOnly . $��80��   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn	   Header$	 Title��1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 �� *
Book.Title+  $	 Date of issue��
 �� *DateOfIssue+ �� StringFormat$ 
dd/MM/yyyy��  $	 Return until��
 �� *
ReturnDate+$ 
dd/MM/yyyy���� -
   $��RenewBtn��$��Renew��$��17(�$	��150��
�������$��
10,10,10,0q�$��Right=�{�.  �� $��2��.+��� $��History��$��23(�  -   $��DataHistory�� .   . $��80��   $	 Title��
 �� *
Book.Title+  $	 Date of issue��
 �� *DateOfIssue+$ 
dd/MM/yyyy��  $	 Return date��
 �� *
ReturnDate+$ 
dd/MM/yyyy��