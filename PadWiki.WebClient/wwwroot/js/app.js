window.addScrollListener = (element, dotnetHelper) => {
    element.onscroll = () => {
        var isAtStart = element.scrollLeft === 0;
        var isAtEnd = element.scrollWidth - element.scrollLeft === element.clientWidth;
        dotnetHelper.invokeMethodAsync('HandleScroll', isAtStart, isAtEnd);
    };
};

window.scrollElement = (element, amount) => {
    const newScrollPosition = element.scrollLeft + amount;
    element.scrollTo({
        left: newScrollPosition,
        behavior: 'smooth'
    });
}

window.isScrollAtStart = (element) => {
    return element.scrollLeft === 0;
};

window.isScrollAtEnd = (element) => {
    return element.scrollLeft + element.clientWidth === element.scrollWidth;
};