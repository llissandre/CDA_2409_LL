$(document).ready(function(){
    let footnotes = $('span[data-footnote]');
    if(footnotes){
        let footnoteDisplay = $('<ol></ol>');
        footnotes.each(function(index, element){
            let current = $(element);
            let footnoteText = current.data('footnote');
            current.css('text-decoration', 'underline dashed')
            .after(`<a href="#footnote-${index+1}" id="footnote-anchor-${index+1}"><sup>[${index+1}]</sup></a>`);
            $(`<li id="footnote-${index+1}">${footnoteText}</li>`)
            .append(`<a href="#footnote-anchor-${index+1}"> [Retour]</a>`).appendTo(footnoteDisplay);
        });
        footnoteDisplay.appendTo('main').wrap('<section id="footnotesDisplay"></section>');
    }
});