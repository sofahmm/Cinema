   M S B A M L   `   `   `  ????A  =Cinema, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Cinema.PagesCinema.Pages  5          Cinema.Pages.AddFilmPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:Cinema.Pages     5      c _MaterialDesignThemes.MahApps, Version=0.2.5.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a_ [MaterialDesignThemes.Wpf, Version=4.6.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5        N? Title$  AddFilmPage??5
      .??5      ?  ? ColumnDefinitions 5   
   ?? 5      ?? 5       ? RowDefinitions 5   
   ?? 5      ?? 5      ?? 5      ?? 5      ?? 5      ?? 5      .+?5   
   ?? -   5         ??Name$ 
posterFilm??5      $??4??5      ??5      ?? *Poster+5      ?? 5   
   -   5         ??Name$ nameTb??5      $??1??5      $??0??5      $??10q?5       $??24(?5!      $	??500??5"      $??75??5#      
???   ?$??2q?5%      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Название??5&         
IsFloating . $??Center=?5(      ?? 5)   
   -   5        $ descriptionTb??5,      $??1??5)      $??1??5*      $??2??5+      $??10q?5-      $??24(?5.      $	??500??5/      $	??250??50      
???   ?$??2q?52       ?? TextWrapping$
 Wrap=?53      $ Описание??54       . $??Center=?56      ?? 57   
   -   5        $ 
durationTb??59      $??1??57      $??3??58      $??10q?5:      $??24(?5;      $	??500??5<      $??75??5=      
???   ?$??2q?5?      $* $Продолжительностть??5@       . $??Center=?5B      ?? 5C   
   -   5        $ 	ageStopTb??5E      $??1??5C      $??4??5D      $??10q?5F      $??24(?5G      $	??500??5H      $??75??5I      
???   ?$??2q?5K      $1 +Возрастное ограничение??5L       . $??Center=?5N      ?? 5P   
   -   5         ??Name$ addPostrBtn??5P      $??4??5R      $??50??5S      $	??300??5T      
????+??$??Добавить фото??5V      $??24(?5W      $??15q?5X      	 ? Cursor$
	 Hand??6   ?? 5Y   
   -   5        $ saveFilmBtn??5Y      $??5??5[      
??? ?|?$??2??5]      $	??400??5^      $??70??5_      $??Сохранить??5`      $??24(?5a      $??15q?5b      $
	 Hand??6   5c      5d      