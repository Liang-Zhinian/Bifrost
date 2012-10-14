﻿Bifrost.features.featureManager.get("Content").defineViewModel(function () {
    var self = this;
    this.currentFeature = ko.observable("home");
    this.currentFeaturePath = ko.computed(function () {
        var path = "/Content/" + self.currentFeature() + "/index";
        return path;
    });

    Bifrost.messaging.messenger.subscribeTo("currentFeatureChanged", function (message) {
        self.currentFeature(message.name);
    });
});