﻿using MauiFirebase.ViewModels;

namespace MauiFirebase;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
		BindingContext = new LoginViewModel(Navigation);
	}
}

