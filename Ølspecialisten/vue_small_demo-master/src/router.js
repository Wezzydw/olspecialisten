import Vue from 'vue'
import Router from 'vue-router'
import Admin from './views/Admin.vue'
import Home from './views/Home.vue'
import AlbumsOverview from "./views/albums/AlbumsOverview";
import AlbumsCreate from "./views/albums/AlbumsCreate";
import AlbumsUpdate from "./views/albums/AlbumsUpdate";
import ShoesList from "./views/shoes/ShoesList";
import Create from "./views/Create";
import Danske from "./views/Danske";
import Svenske from "./views/Svenske";
import Norske from "./views/Norske";
import desc from "./views/product_description";
import Basket from "./views/Basket";
import order_page from "./views/order_page";

Vue.use(Router)

export default new Router({
  mode: 'history',
  base: process.env.BASE_URL,
  routes: [
    {
        path: '/order_page',
        name: 'order_page',
        component: order_page
    },{
        path: '/basket',
        name: 'basket',
        component: Basket
    },{
      path: '/desc/:id',
      name: 'desc',
      component: desc
    },{
      path: '/danske',
      name: 'danske',
      component: Danske
    },{
      path: '/norske',
      name: 'norske',
      component: Norske
    },{
      path: '/svenske',
      name: 'svenske',
      component: Svenske
    },{

      path: '/admin',
      name: 'admin',
      component: Admin
    },{
      path: '/',
      name: 'home',
      component: Home
    },
    {
      path: '/albums-create',
      name: 'albums-create',
      component: AlbumsCreate
    },
    {
      path: '/albums-update/:id',
      name: 'albums-update',
      component: AlbumsUpdate
    },
    {
      path: '/albums',
      name: 'albums',
      component: AlbumsOverview
    },
    {
      path: '/create',
      name: 'create',
      component: Create
    },
    {
      path: '/shoes',
      name: 'shoes',
      component: ShoesList
    },
    {
      path: '/about',
      name: 'about',
      // route level code-splitting
      // this generates a separate chunk (about.[hash].js) for this route
      // which is lazy-loaded when the route is visited.
      component: () => import(/* webpackChunkName: "about" */ './views/Create.vue')
    }
  ]
})
