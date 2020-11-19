import Vue from "vue";
import Router from "vue-router";
import TvShows from "@/components/tvshows";
import Reports from "@/components/reports";


Vue.use(Router);

let router = new Router({
  routes: [
    {
      path: '/',
      name: 'tvshows',
      component: TvShows
    },
    {
      path: '/reports',
      name: 'reports',
      component: Reports
    }
  ]
});

export default router;
