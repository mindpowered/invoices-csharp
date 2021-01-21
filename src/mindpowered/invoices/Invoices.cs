/**
 * Copyright Mind Powered Corporation 2020
 * 
 * https://mindpowered.dev/
 */

using System.Collections.Generic;

/**
 * An Library for Creating Invoices
 */
namespace mindpowered.invoices {
	public delegate void MyCallbackDelegate(object o);

	public class Invoices
	{
		public Invoices()
		{
			global::maglev.MagLev bus = global::maglev.MagLev.getInstance("default");
			global::invoices.Invoices myinstance = new global::invoices.Invoices(bus);
		}

		/**
		 * Create a new invoice
		 * @param clientId 
		 * @param invoiceNumber 
		 * @param date 
		 * @param dueDate 
		 * @param notes 
		 * @return {string} New invoice id
		*/
		public string CreateInvoice(string clientId, string invoiceNumber, string date, string dueDate, string notes)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(clientId);
			args.push(invoiceNumber);
			args.push(date);
			args.push(dueDate);
			args.push(notes);
			string ret = "";
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (string) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("Invoices.CreateInvoice", args, async_callback);
			return ret;
		}

		/**
		 * Delete an invoice
		 * @param invoiceId 
		*/
		public void DeleteInvoice(string invoiceId)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(invoiceId);
			MyCallbackDelegate async_delegate = delegate (object async_ret) {};
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("Invoices.DeleteInvoice", args, async_callback);
		}

		/**
		 * 
		 * @param invoiceId 
		 * @param clientId 
		 * @param invoiceNumber 
		 * @param date 
		 * @param dueDate 
		 * @param notes 
		*/
		public void ChangeInvoice(string invoiceId, string clientId, string invoiceNumber, string date, string dueDate, string notes)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(invoiceId);
			args.push(clientId);
			args.push(invoiceNumber);
			args.push(date);
			args.push(dueDate);
			args.push(notes);
			MyCallbackDelegate async_delegate = delegate (object async_ret) {};
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("Invoices.ChangeInvoice", args, async_callback);
		}

		/**
		 * 
		 * @param invoiceId 
		 * @return {object} 
		*/
		public object GetInvoiceSummary(string invoiceId)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(invoiceId);
			object ret = null;
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (object) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("Invoices.GetInvoiceSummary", args, async_callback);
			return ret;
		}

		/**
		 * 
		 * @param invoiceId 
		 * @return {object[]} Line items for invoice
		*/
		public object[] GetLineItems(string invoiceId)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(invoiceId);
			object[] ret = {};
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (object[]) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("Invoices.GetLineItems", args, async_callback);
			return ret;
		}

		/**
		 * 
		 * @param invoiceId 
		 * @param accountId 
		 * @param description 
		 * @param taxes 
		 * @param quantity 
		 * @param price 
		 * @return {double} lineNumber
		*/
		public double AddLineItem(string invoiceId, string accountId, string description, object taxes, double quantity, double price)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(invoiceId);
			args.push(accountId);
			args.push(description);
			args.push(taxes);
			args.push(quantity);
			args.push(price);
			double ret = 0;
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (double) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("Invoices.AddLineItem", args, async_callback);
			return ret;
		}

		/**
		 * 
		 * @param invoiceId 
		 * @param lineNumber 
		 * @param accountId 
		 * @param description 
		 * @param taxes 
		 * @param quantity 
		 * @param price 
		*/
		public void ChangeLineItem(string invoiceId, double lineNumber, string accountId, string description, object taxes, double quantity, double price)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(invoiceId);
			args.push(lineNumber);
			args.push(accountId);
			args.push(description);
			args.push(taxes);
			args.push(quantity);
			args.push(price);
			MyCallbackDelegate async_delegate = delegate (object async_ret) {};
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("Invoices.ChangeLineItem", args, async_callback);
		}

		/**
		 * 
		 * @param invoiceId 
		 * @param lineNumber 
		*/
		public void RemoveLineItem(string invoiceId, double lineNumber)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(invoiceId);
			args.push(lineNumber);
			MyCallbackDelegate async_delegate = delegate (object async_ret) {};
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("Invoices.RemoveLineItem", args, async_callback);
		}

		/**
		 * 
		 * @param clientId 
		 * @return {object[]} 
		*/
		public object[] GetInvoicesByClient(string clientId)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(clientId);
			object[] ret = {};
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (object[]) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("Invoices.GetInvoicesByClient", args, async_callback);
			return ret;
		}

		/**
		 * 
		 * @param page 
		 * @param perpage 
		 * @return {object[]} 
		*/
		public object[] GetAllInvoices(double page, double perpage)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(page);
			args.push(perpage);
			object[] ret = {};
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (object[]) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("Invoices.GetAllInvoices", args, async_callback);
			return ret;
		}

		/**
		 * Returns the Invoice ID or null
		 * @param invoiceNumber 
		 * @return {dynamic} 
		*/
		public dynamic FindInvoiceByNumber(string invoiceNumber)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(invoiceNumber);
			dynamic ret = null;
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (dynamic) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("Invoices.FindInvoiceByNumber", args, async_callback);
			return ret;
		}

	}
}

