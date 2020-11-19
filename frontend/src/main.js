import Vue from "vue";
import App from "./App.vue";
import router from "./router";
import BootstrapVue from 'bootstrap-vue';
import './custom.scss';
import axios from 'axios';
import { library } from '@fortawesome/fontawesome-svg-core'
import { faStar, faThumbsUp } from '@fortawesome/free-solid-svg-icons'
import { FontAwesomeIcon } from '@fortawesome/vue-fontawesome'

library.add(faStar, faThumbsUp)

Vue.component('font-awesome-icon', FontAwesomeIcon)
Vue.use(BootstrapVue);

Vue.config.productionTip = false;
Vue.prototype.$axios = axios;

new Vue({
  router,
  render: h => h(App)
}).$mount("#app");
