   M S B A M L   `   `   `  ����D  @TicketBuy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:TicketBuy	TicketBuy  5   	       TicketBuy.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:TicketBuy     5   	     � Title$  Login��5	   	   $	��300��6   $	��400��6'   $	��450��66   $	��800��6C    � WindowStartupLocation$ CenterScreen=�6O   .��5
      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      .+�5   
   �� -   5         ��Name$ 	loginText��5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
Логин��6%   $��1��6L   $��1��6Y   $��Center=�6i   G� 5   
   -   5         G�Name$ passwordText��5      $ Пароль��6,   $��2��6T   $��1��6a   $��Center=�6q   6�   �� 5   
   -   5        $ passwordText2��5      $ Пароль��6)   $��2��6Q   $��1��6^   $��Center=�6n   $y�Hidden=�6�   6�   �� 5   
   -   5         ��Name$ passV��5      $��2��6   $��2��6/   $
��Left=�6<   $��eye.png��6�   $��10, 30, 0, 30q�6�   6�   �� 5   
   -   5         ��Name$ loginB��5      $��1��6!   $��3��61   $��Login��6>   6e   �� 5   
   -   5        $
 RegB��5      $��1��6   $��4��6/   $	��Top=�6<   $��Registration��6T   6�   �� 5   
   $��0,10,0,0q�6   $��
ticket.png��6"   $��1��66   6H   5      5      