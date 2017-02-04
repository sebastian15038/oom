﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;

namespace lesson2
{
	public class Book
	{
		private decimal m_price;

		public Book(string title, string isbn, decimal price, Currency currency)
		{

			Title = title;
			ISBN = isbn;
			//UpdatePrice(price, currency);
		}

        public string Title {
            get;
        }

        public string ISBN { get; }









		public Currency Currency { get; private set;}

		/// <summary>
		/// Gets the book's price in the given currency.
		/// </summary>
		public decimal GetPrice(Currency currency)
		{
			// if the price is requested in it's own currency, then simply return the stored price
			if (currency == Currency) return m_price;

			// use web service to query current exchange rate
			// request : http://download.finance.yahoo.com/d/quotes.csv?s=EURUSD=X&f=sl1d1t1c1ohgv&e=.csv
			// response: "EURUSD=X",1.0930,"12/29/2015","6:06pm",-0.0043,1.0971,1.0995,1.0899,0
			var key = string.Format("{0}{1}", Currency, currency); // e.g. EURUSD means "How much is 1 EUR in USD?".

			// create the request URL, ...
			var url = string.Format(@"http://download.finance.yahoo.com/d/quotes.csv?s={0}=X&f=sl1d1t1c1ohgv&e=.csv", key);
			// download the response as string
			var data = new WebClient().DownloadString(url);
			// split the string at ','
			var parts = data.Split(',');
			// convert the exchange rate part to a decimal 
			var rate = decimal.Parse(parts[1], CultureInfo.InvariantCulture);

			// and finally perform the currency conversion
			return m_price * rate;
		}

		/// <summary>
		/// Updates the book's price.
		/// </summary>
		/// <param name="newPrice">Price must not be negative.</param>
		/// <param name="newCurrency">Currency.</param>
        /// 
		public void UpdatePrice(decimal newPrice, Currency currency)
		{
			if (newPrice < 0) throw new ArgumentException("Price must not be negative.", nameof(newPrice));
			m_price = newPrice;
			Currency = currency;
		}
	}
}

