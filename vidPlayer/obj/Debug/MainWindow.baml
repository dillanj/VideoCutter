   M S B A M L   `   `   `  ����D  @vidPlayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:vidPlayer	vidPlayer  5   	       vidPlayer.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:vidPlayer     5   	   -   5          �Name$  No_Name��5   	    � Title$ MediaPlayer��5   	   $	��450��6   $	��800��6*   $	��450��67   $	��800��6G   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��3* �6   �� 5      $	��19* �6   .+�5   
   �� -   5        $��Upload Time Stamps��5      $
��Left=�6.   $��517,350,0,0q�6I   $	��Top=�6^   $	��120��6v   $��1��6�   �� 5   
   -   5         ��Name$ 
TimesCombo��5      $
��Left=�6'   $��517,374,0,0q�6B   $	��Top=�6W   $	��120��6o   $��1��6{   �� 5   
   -   5        $��Video��5      $
��Left=�6"   $��
74,350,0,0q�6=   $	��Top=�6Q   $��75��6i   $��2��6�   r� 5   
   -   5        $��mePlayer��5       r� LoadedBehavior$ Manual=�6'   $��
10,0,10,77q�6?   $��2��6S   $	��772��6g   $	��342��6s   �� 5   
   $��227,347,349,13q�6   $��1��6-   .+�5      � $��Center=�6   .+�5      �� -   5        $��btnPlay��5      .��6>   Play6D   �� 5      -   5        $��btnPause��5      $	��5,0q�6)   .��6M   Pause6T   �� 5      -   5        $��btnStop��5      .��6>   Stop6D   5      �� 5      -	   5         ��Name$ 	lblStatus��5      $��Not playing...��6'   $��Center=�6@   $��5q�6d   5      �� 5   
   -
   5         ��Name$
 Edit��5      $
��Edit��6   $��1��6.   $
��Left=�6>   $��452,350,0,0q�6Y   $	��Top=�6n   $��38��6�   6�   5      5      