   M S B A M L   `   `   `  ????C  ?Airlines, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Airlines.viewsAirlines.views  5   	   "    Airlines.views.AddUserWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Airlines.views     5   	     ? Title$  AddUserWindow??5   	   $	??450??6   $	??400??6,    ? WindowStartupLocation$ CenterScreen=?68   .??5	      ? .+?5
   
   ? $??10q?6    ? RowDefinitions 5      ?? 5      $??50 ?6    ?? 5      $??50 ?6    ?? 5      $??50 ?6    ?? 5      $??60 ?6    ?? 5      $??50 ?6    ?? 5      $??50 ?6    ?? 5      $
??Auto ?6    .+?5      ? $??0??6   $??16q?6     ? ColumnDefinitions 5      ?? 5      $
??0.3* ?6'   ?? 5      .+?5      ?? $??0??6   $
??Left=?6,   Email address:6W   ?? 5      -   5        $??tbEmail??5   *   $??1??6   6<   5      ? 5      $??1??6   $??16q?6     5      ?? 5      $
??0.3* ?6'   ?? 5      .+?5!      ?? $??0??6   $
??Left=?6,   First name:6T   ?? 5"      -   5        $??tbFirstName??5"   *   $??1??6   6@   5#      ? 5$      $??2??6   $??16q?6     5%      ?? 5&      $
??0.3* ?6'   ?? 5'      .+?5)      ?? $??0??6   $
??Left=?6,   
Last name:6S   ?? 5*      -   5        $??
tbLastName??5*   *   $??1??6   6?   5+      ? 5,      $??3??6   $??16q?6     5-      ?? 5.      $
??0.3* ?6'   ?? 5/      .+?51      ?? $??0??6   $
??Left=?6,   	Office:6P   ?? 52      -   5        $??	cbOffices??52   9   $??1??6   $??14(?6+    ?? DisplayMemberPath$ Title??6J   6f   53      ? 54      $??4??6   $??16q?6     55      ?? 56      $
??0.3* ?6'   ?? 57      .+?59      ?? $??0??6   $
??Left=?6,   
Birthdate:6S   ?? 5:      -   5        $??tbBirthdate??5:   *   $??1??6   .??6=   
mm.dd.yyyy6I   5;      ? 5<      $??5??6   $??16q?6     5=      ?? 5>      $
??0.3* ?6'   ?? 5?      .+?5A      ?? $??0??6   $
??Left=?6,   	Password:6R   ?? 5B      -   5        $??
tbPassword??5B   *   $??1??6   6>   5C      ? 5D      $??6??6    5E      ?? 5F      ?? 5G      .+?5I      ?? -   5        $??0??5I      $	??100??6)   .??6K   Save5K      ?? 5L       ?? IsCancel . $??1??6)   $	??100??69   .??6E   Cancel5N      5O      5P      5Q      5R      