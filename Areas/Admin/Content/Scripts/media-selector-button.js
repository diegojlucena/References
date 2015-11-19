$(function () {

    var elements = $('[data-toggle="input-media-selector"]');
    elements.each(function () {
        var $this = $(this);
        if ($this.is('input')) {
            $this.wrap("<div class='input-group'></div>");
            var ig = $('<span>').addClass('input-group-btn');
            var sb = $('<a>').addClass('btn btn-default')
                .html("ou Selecione")
                .on('click', function () {
                var mediaSelector = new MediaSelector({
                    onSelected: function (info) {
                        $this.val(info.Url);
                        $.featherlight.close();
                    }
                });
                mediaSelector.show($);
            });

            sb.appendTo(ig);
            $this.after(ig);
        }

    });



});