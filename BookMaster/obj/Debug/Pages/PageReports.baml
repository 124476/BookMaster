   M S B A M L   `   `   `  ����E  ABookMaster, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:BookMaster.PagesBookMaster.Pages  5      "    BookMaster.Pages.PageReports   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:BookMaster.Pages     5        N� Title$  PageReports��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      6   .+�5   
   �� $��Reports��6   $��25(�6#   $��
10,10,0,10q�61   6G   �� 5   
   -   5         ��Name$ 
ComboPoisk��5      $	��150��6'   $��17(�63   $��30��6A   $��Right=�6M   $��0,10,210,10q�6i   6�   �� 5   
   -   5         ��Name$ 	ExportBtn��5      $��Export��6$   $	��150��65   $��17(�6A   
�������$��30��6b   $��Right=�6n   $��
0,10,10,10q�6�   6�   o� 5   
   $��1��6   $��17(�6   .@�5      m� -   5        $��	Reminders��5   *   $��	Reminders��6   6U   m� 5      -   5        $��BookHistory��5   -   $��Book history��6   6\   5      � 5   
   $��2��6    � ColumnDefinitions 5      �� 5      -   5         ��Name$ 	GridPanel��5   #   $��0 �66   6B   �� 5      6%   .+�5      �� $��Center=�6   $	��200��66   .+�5      �� $��Book ID��6   $��17(�6+   6;   �� 5      -   5         ��Name$ 	PoiskText��5      $��17(�6Q   6a   �� 5       -   5         ��Name$ SearchedTitle��5       $��21(�63   6C   �� 5!      -   5        $ SearchedSubtitle��5!      $��17(�66   6F   5"      &   System.Windows.Controls.DataGrid  5#      -	   5          Name$ DataReminders��5#      	   AutoGenerateColumns	 .  
   
IsReadOnly
 . $��17(�6\   $��1��6j      Columns 5$      0  *System.Windows.Controls.DataGridTextColumn  5%      ,  &System.Windows.Controls.DataGridColumn   Header$ Title��6)   -
   5        ColumnTitle��1  +System.Windows.Controls.DataGridBoundColumn   Binding 5%   8   �� *
Book.Title+6n     5&      $ Customer��6)    6;   �� *Customer.Name+6_     5'      $ Date of issue��6)    6@   �� *DateOfIssue+ �� StringFormat$ 
dd/MM/yyyy��6}     5(      $ Return until��6)    6?   �� *
ReturnDate+$ 
dd/MM/yyyy��6{   5*      5+      5,      5-      