(function(){
	var app = angular.module('store',[]);

	app.controller('StoreController', function() {
		var store = this;
		store.products = [];

		$.ajax({
		    url: 'http://localhost:13389/api/Product',
		    type: 'GET',
		    dataType: 'jsonp',
		    success: function (data) {
		    	store.products = data;
		    }
		});
	});

})();

