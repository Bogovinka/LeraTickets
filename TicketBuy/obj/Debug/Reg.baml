   M S B A M L   `   `   `  ����D  @TicketBuy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:TicketBuy	TicketBuy  5   	       TicketBuy.Reg   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:TicketBuy     5   	     � Title$	  Reg��5	   	   $	��450��6   $	��500��6"    � WindowStartupLocation$ CenterScreen=�6.   .��5
      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      .+�5   
   �� -   5         ��Name$ 	loginText��5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
Логин��6%   $��1��6L   $��1��6Y   $��Center=�6i   6�   G� 5   
   -   5         G�Name$ passwordText��5      $ Пароль��6,   $��2��6T   $��1��6a   $��Center=�6q   6�   �� 5   
   -   5        $ passwordText3��5      $ Пароль��6)   $��2��6Q   $��1��6^   $��Center=�6n   $y�Hidden=�6�   6�   G� 5   
   -   5        $ passwordText2��5      $ Повтор пароля��6-   $��3��6\   $��1��6i   $��Center=�6y   6�   �� 5   
   -   5         ��Name$ nextB��5      $��1��6    $��4��60   $��Create��6=   6d   �� 5   
    �� Orientation$ 
Horizontal=�6   $��2��6.   $��2��6>   .+�5      �� -   5        	 ��Name$	 passV��5      $��2��6#   $��2��63   $
��Left=�6@   $��eye.png��6�   $��10, 25, 0, 25q�6�   6�   �� 5      -   5        
 ��Name$

 prov��5      $
��Left=�6"   $��Center=�6=   $��2��6X   $��2��6h   $��проверка��6u   $��	10,0,10,0q�6�   ���	#FFC5C5C5 � ToolTip 5       _� 5!      .��5"      �� ��Идеальный пароль - от 8 символов, есть большая буква, есть маленькая буква, есть цифры.5$      5&      5(      5)      �� 5*   
   -   5        $
 RegB��5*      $��1��6   $��5��6/   $	��Top=�6<   $
��Exit��6T   6x   5+      5,      