import Vue from "vue";
import Router from "vue-router";
import Home from "@/components/home";
import TvShows from "@/components/tvshows";


Vue.use(Router);

let router = new Router({
  routes: [
    {
      path: '/',
      name: 'home',
      component: Home
    },
    {
      path: '/tvshows',
      name: 'tvshows',
      component: TvShows
    }
  ]
});

export default router;
