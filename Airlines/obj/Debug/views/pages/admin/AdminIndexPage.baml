   M S B A M L   `   `   `  ????C  ?Airlines, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Airlines.views.pages.adminAirlines.views.pages.admin  5      /    )Airlines.views.pages.admin.AdminIndexPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:Airlines.views.pages.admin     5        N? 
Background
  ????? N? Title$ AdminIndexPage??5
       ? 	Resources 5         BgBrush1 ?? 
StartPoint ?? EndPoint ? Offset ? Color  HighlightRow ?? 
TargetType)  #System.Windows.Controls.DataGridRow ?? Triggers	 ?? Binding
 ?? Value ?? Property ?? Value??%
  &	        &	 b     7   ?? 5   
   $	 0,0&?6/   $	 0,1&?6@   .??5      ? $ 1Q?6   $	 Red??6&   5      ?? 5   
   "  6%    5      ?? 5      	 6   ?? *Active+	
 false69   .a?5      ??  ? ??8   63   5      5      5      .??5      ?  ? RowDefinitions 5   
   ?? 5      $
??0.2* ?6   ?? 5      ?? 5      $??4* ?6   ?? 5      $
??0.7* ?6   .+?5   
   o? $??0??6   .@?5      m? -   5        $??MenuAddUser??5   7   $??Add user??6   $??20(?6)   5!      m? 5"      -   5        $??MenuExit??5"   3   $
??Exit??6   $??20(?6%   5$      5&      ? 5'   
   $??1??6    5(      ?? 5)      ?? 5*      .+?5,      ??  ?? Orientation$ 
Horizontal=?6   $
??Left=?62   .+?5-      ?? $??20(?6   $??Center=?6&   .??6A   
Offices:6L   ?? 5.      -   5        $??	cbOffices??5.      $??20(?6,   $??Center=?6:    ?? DisplayMemberPath$ Title??6\   $??45 0 0 0q?5/   E   $	??250??6W   $??40??6c   50      51      53      ? 54   
   $??2??6   .+?55      &   System.Windows.Controls.DataGrid  -   5        $??dgUsers??55   Z      RowStyle# [ 6   $??50q?6@   $??20(?6L      
IsReadOnly .    AutoGenerateColumns .     Columns 56      0  *System.Windows.Controls.DataGridTextColumn  57      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name??6G      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6U   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6)   ?? *	FirstName+6U     58      $ LastName??6F   $	 200 6X    6)   ?? *
LastName+6X     59      $	 Age??6A   $	 200 6N    6)   ?? *Age+6N     5:      $ 	User Role??6H   $	 200 6[    6)   ?? *
Role.Title+6[     5;      $ Email Address??6C   $	 200 6Z    6)   ?? *Email+6Z     5<      $ Office??6J   $	 200 6Z    6)   ?? *Office.Title+6Z   5>      5?      ? 5@   
   $??3??6    ? ColumnDefinitions 5A      ?? 5B      $
??0.5* ?6#   ?? 5C      ?? 5D      .+?5F      ? $??50 0 0 0q?6   $??0??6%   .+?5G      ?? -   5        $??btnEditRole??5G      $
??Left=?6F   $	??200??6a   $??60??6m   $??20(?6y   .??6?   Change role6?   5H      ? 5I      $??50 0 0 0q?6   $??1??6%   .+?5J      ?? -   5        $??btnEnableLogin??5J      $
??Left=?6L   $	??200??6g   $??60??6s   $??20(?6   .??6?   Enable/Disable login6?   5K      5L      5M      5N      