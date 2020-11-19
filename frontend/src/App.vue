<template>
  <div id="app">
     <header>
      <b-navbar>
        <b-navbar-toggle target="nav-collapse"></b-navbar-toggle>
        <b-navbar-brand to="/">TvMaze</b-navbar-brand>
        <b-collapse is-nav id="nav-collapse">
          <b-navbar-nav> 
            <b-nav-item>
              <router-link class="nav-link" to="/">
                Serier
              </router-link>             
            </b-nav-item>
            <b-nav-item>
              <router-link class="nav-link" to="/reports">
                Rapporter
              </router-link>             
            </b-nav-item>
          </b-navbar-nav>
        </b-collapse>
      </b-navbar>
    </header>
    <main>
      <router-view/>
    </main>
  </div>
</template>

<script>
export default {
  name: 'App'
}
</script>

<style lang="scss">
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #e3eef9;
}

#nav {
  padding: 30px; 
}

a {
    font-weight: bold;
    color: #e3eef9;
}

</style>
