   M S B A M L   `   `   `  ����@  <POD12, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:POD12POD12  5          POD12.Dokumentation   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      %localclr-namespace:POD12     5        N� Title$  Dokumentation��5	      $	��800��6   $	��600��6)    N� 
Background �	#FF323232.��5      � .+�5   
   �� -   5         ��Name$ label��5      $��Dokumentacja��6   $
��Left=�66   $��
262,64,0,0q�6Q   $	��Top=�6e   
�������$��36(�6�   $
��Bold"�6�   �� 5   
   -   5        $ label1��5      $����Algorytm RSA opiera się na dwóch wartościach p i q.
n=pq	phi=(p-1)(q-1)	e jest względnie pierwsza z phi	((e * i) - 1) % phi != 0

e i n stanowią klucz publiczny, a d i n stanowią klucz prywatny.
szyfrowanie: c=(m^e)%n, c-wiadomość zaszyfrowana m-wiadomość jawna 
deszyfrowanie: m=(c^d)%n, c-wiadomość zaszyfrowana m-wiadomość jawna

Algorytm RSA jest realizowany klasą RSA

Visual Studio 2017
Autor: Agnieszka Gregulec��6    $
��Left=�63  $��
58,166,0,0q�6N  $	��Top=�6b  
�������$��18(�6�  $	��682��6�  $	��400��6�  5      5      