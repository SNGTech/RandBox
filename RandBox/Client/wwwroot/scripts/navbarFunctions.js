window.changeOnScroll = () => {
    const navbar = document.querySelector('.navbar');
    const page = document.querySelector('.page');
    console.log(page);
    const scrollWatcher = document.createElement('div');

    scrollWatcher.setAttribute('data-scroll-watcher', '');
    navbar.before(scrollWatcher);


    const navObserver = new IntersectionObserver((entries) => {
        navbar.classList.toggle('scrolled', !entries[0].isIntersecting);
    });

    navObserver.observe(scrollWatcher);
};