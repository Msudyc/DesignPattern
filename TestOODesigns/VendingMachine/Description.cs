/*

Design a simplified vending machine.

ref: http://csrocks.net/pages/oops_page_2.aspx#2

list use-cases:
1.User dispenses an item
User inserts coin in the coin slot of the vending machine.
User selects an item to dispense.
The vending machine checks the total value of the inserted coins in the coin slot.
User dispenses an item.
The vending machine instructs the coin slot to return the change.
2.User cancels the selection
User inserts coins in the coin slot of the vending machine.
User cancels the payment.
The vending machine returns the inserted change (coins).
3.Vendor updates the vending machine inventory.
The vendor first puts the vending machine in maintenance mode.
The vendor checks the current inventory.
The vendor updates the inventory.
4.Vendor refills the coin slot
Vendor sets the coin slot in maintenance mode.
Vendor refills the coins.

All the relevant nouns and verbs are underlined from the above use-case.
The Nouns:  
1.User
2.VendingMachine
3.Item
4.CoinSlot
5.Coin
6.Vendor
7.Payment
8.Inventory
The Verbs:  
1.CoinSlot
Insert (coin)
Check total value
Return change
Refill Coins
Cancel Payment
Put in maintenance mode
Instruct the coin slot
2.VendingMachine
Select Item
Dispense Item
Put in maintenance mode
Check current inventory
Update inventory

Convert the above nouns and the verbs into concrete classes and methods.
The Classes:
User
 Not required, since this exercise is about designing the vending machine.
Class: VendingMachine
 Method: dispenseItem
    The verbs "Select Item" and "Dispense Item" was merged together to form 
    method "dispenseItem".
 Method: setMaintenanceMode
 Method: getUpdatedInventory
    Maps to "Check current inventory"
 Method: updateInventory
 Method: Instruct the coin slot to return change
    Method not required. The VendingMachine simply calls the "returnChange"
    method on the CoinSlot.
Class: Item
 We did not identify any verbs for the item class. We could have also identified
 the verbs for the item class, but it is fairly straight forward to define the 
 item class. The main methods are below:
 Method: Get/set for Unit Price
 Method: Get/set for Item Id
 Method: Get/set for Item name
Class: CoinSlot
 Method: insertCoin
 Method: refillCoin
 Method: setMaintenanceMode
 Method: returnChange
 Method: getCurrentPayment
    Maps to get total value of the payment
 Method: cancelCurrentPayment
Class: Coin
 The coin can be an enum and we will support three different values: Nickel, Dime
  and Quarter.
Vendor
 Not required, since this exercise is about designing the vending machine.
Class: Payment
 Since we are doing basic transactions, we don't really need a class for this
 (though we could create one if our use cases became completed).
Class: Inventory
 The inventory in our case is simply a field in the VendingMachine class with
 the data type being List. Again, if we had more complicated use cases we could 
 have created one Inventory class.
Class: Display

Note: KeyPad is simplified in Vending machine as some functions.

Patterns:
singleton: Vending machine, Coin slot
Observer: Display observer, vending machine, coin slot, observable
State: Maintanance state, Operation state

*/