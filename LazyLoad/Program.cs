using LazyLoad.Pattern;

var lazyLoad = new OrderLazy();

lazyLoad.PrintLabel();

var lazyProxy = (new OrderFactory()).CreateOrder();

lazyProxy.PrintLabel();
