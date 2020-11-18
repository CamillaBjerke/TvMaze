<template>
  <div class="TvShows">
    <h1 class="uff">TvShows</h1>
    <div class= "ille">
    
    <!--{{ results.data[0].id }}-->
    
    <table>
        <tr>
            <th>Navn</th>
            <th>Summary</th>
        </tr>
        <tr v-for="res in results.data" :key="res.Id">
            <td>{{ res.name }}</td>
            <td>{{ res.summary }}</td>
        </tr>
    </table>
    </div>
  </div>
</template>

<style lang="scss">
.uff {
  background-color: aquamarine;
}

.ille {
  background-color: pink;
}
</style>

<script>
import api from '@/TvMazeApiService'

export default {
  name: 'Tvshows',
  data() {
      return{
            results: []
    }
  },
  async created(){
      this.results = await api.getAll()
  }
}
</script>
