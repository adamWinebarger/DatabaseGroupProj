   M S B A M L   `   `   `  ????O  KGV Testing Program 2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:GV_Testing_Program_2GV_Testing_Program_2  5   	   %    GV_Testing_Program_2.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:GV_Testing_Program_2     5   	     ? Title$  
MainWindow??5   	   $	??500??6   $	??900??6)   .??5	      ? .+?5
   
   ?? $?? GV Testing... Program??6   $??Center=?61   $	??Top=?6N    J? RenderTransformOrigin$ 0.442,0.048&?6f   $??30(?6?   $	??900??6?   $
??Bold"?6?   $??2??6?   ???	#FFDDDDDD$??75??6?   $??	15,10,0,0q?6?   ?? 5   
   -   5         ??Name$ QuickScoreButton??5      $??Two \nLines??6+   $
??Left=?6A   $??	10,87,0,0q?6\   $	??Top=?6o   $??46??6?   $	??115??6?   6?   ?? 5   
   -   5        $ TakeTestButton??5      $??
New Tester??6)   $
??Left=?6>   $??
140,87,0,0q?6Y   $	??Top=?6m   $??46??6?   $	??115??6?   6?   ?? 5   
   -   5        $ showResultsButton??5      $??Show Results??6,   $
??Left=?6C   $??
270,87,0,0q?6^   $	??Top=?6r   $??46??6?   $	??100??6?   6?   ?? 5   
   -   5         ??Name$ 	SearchBox??5      $
??Left=?6%   $??20??6@   $??
15,150,0,0q?6L    ?? TextWrapping$
 Wrap=?6`   $	??Top=?6t   $	??240??6?   
???????6?   ?? 5   
   -   5        $  ToggleAdvancedSearchButton??5      $??Advanced Search Options??65   $
??Left=?6W   $??270,150,0,0q?6r   $	??Top=?6?   $	??150??6?   ?? 5   
   -   5         ??Name$ lastNameCheckBox??5      $??	Last Name??6-   $
??Left=?6A   $??639,155,0,0q?6\   $	??Top=?6q    d? 	IsChecked$
 TrueY?6?   ?? 5   
   -   5        $ firstNameCheckBox??5      $??
First Name??6.   $
??Left=?6C   $??434,155,0,0q?6^   $	??Top=?6s   $ 0.21,-0.593&?6?   $
 TrueY?6?   ?? 5   
   -   5        $ middleNameCheckBox??5      $??Middle Name??6/   $
??Left=?6E   $??528,155,0,0q?6`   $	??Top=?6u   $ 0.572,0.157&?6?   $
 TrueY?6?   ?? 5   
   -	   5        $ RefreshButton??5      $??Refresh??6(   $
??Left=?6:   $??
789,87,0,0q?6U   $	??Top=?6i   $??33??6?   $??75??6?   ?? 5   
   -
   5        $ DeleteButton??5      $??Delete??6'   $
??Left=?68   $??789,135,0,0q?6S   $	??Top=?6h   $??33??6?   $??75??6?   $ 0.589,-0.065&?6?   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ Table??5      $??25,195,25,25q?6"      	RowHeight$ 20Q?68   	   MinColumnWidth$	 40Q?6H   
???????
   RowBackground
 ?	#FFDDDDDD   AlternatingRowBackground ?	#FFFFFFFF   
IsReadOnly$
 True??6?      CanUserReorderColumns$ False??6?      CanUserResizeColumns$ False??6?      CanUserResizeRows$ False??6?      CanUserSortColumns$ False??6     AutoGenerateColumns$
 True??6d   ? 	Resources 5      )  #System.Windows.Controls.DataGridRow ?? 
TargetType??%E   '        ?? 5      "  6   .?5       -   5        5!      5"         Columns 5#      4  .System.Windows.Controls.DataGridCheckBoxColumn  5$      ,  &System.Windows.Controls.DataGridColumn   HeaderStringFormat$ Hello??6)      
IsReadOnly$
 True??6D     5%      5'      5)      5*      