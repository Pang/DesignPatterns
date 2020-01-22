## Observer

The Subject interface is the Publisher and the Observer is the subscriber. This means the Observer listens to any changes from the Subject type object and reacts.

The interface for Subject has the functions 'Register()' 'Unregister()' and 'notifyObservers()'. Register adds the new subscribed observer to an array list of observers and the notify function will, in this case, will cycle through the observers, sending the new piece of data by calling the 'update()' method inside the observer and passing that new data through it's parameters.

This type of Design Pattern is useful for a bidding application. For example, when a person makes a higher bid for an item, the auctioneer could accept it - which returns an update to each subscribed watcher to notify them of the new bid.