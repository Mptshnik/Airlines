   M S B A M L   `   `   `  ????C  ?Airlines, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Airlines.views.pages.userAirlines.views.pages.user  5      -    'Airlines.views.pages.user.UserIndexPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:Airlines.views.pages.user     5        N? Title$  UserIndexPage??5	       N? 
Background
 ?????.??5      ?  ? RowDefinitions 5   
   ?? 5      $
??0.2* ?6   ?? 5      ?? 5      $??4* ?6   .+?5   
   o? $??0??6   .@?5      m? -   5        $??MenuExit??5   3   $
??Exit??6   $??20(?6%   5      5      ? 5   
   $??1??6    5      ?? 5      ?? 5      .+?5      (? $??25 0 0 0q?6   $	??300??6(   $
??Left=?67   $??0??6R   .??5      ?? -   5        $??	tbWelcome??5      $??Center=?6.   $??Welcome??6I   5      (? 5       $??1??6   $	??300??6#   $??Center=?62   .??5!      ?? -   5        $??tbTimeSpent??5!      5"      5#      ? 5$   
   $??2??6   .+?5%      &   System.Windows.Controls.DataGrid  -   5        $??
dgSessions??5%   1   $??50q?6   $??20(?6#      AutoGenerateColumns .     Columns 5&      0  *System.Windows.Controls.DataGridTextColumn  5'      ,  &System.Windows.Controls.DataGridColumn   Header$
 Date??6B      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6P   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6)   ?? *Date+6P     5(      $ 	LoginTime??6G   $	 200 6Z    6)   ?? *	LoginTime+6Z     5)      $ 
LogoutTime??6H   $	 200 6\    6)   ?? *
LogoutTime+6\     5*      $ TimeSpentOnSystem??6O   $	 200 6j    6)   ?? *TimeSpentOnSystem+6j     5+      $ LogoutReason??6J   $	 200 6`    6)   ?? *LogoutReason+6`   5-      5.      5/      50      