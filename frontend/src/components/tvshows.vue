<template>
  <div class="TvShows">
    <h1>Serier</h1>
    <div class="content">
      <div class="mycard">
        <b-card-group deck v-for="res in results.data" :key="res.Id">
          <b-card
            :header="res.name"
            :img-src="res.image.medium"
            :img-alt="res.name"
            :img-width="80"
            img-top
            style="max-width: 15rem;"
            class="mb-3"
          >
            <b-card-text>
              <p>Type: {{res.type}}</p>
              <p>Språk: {{res.language}}</p>
            <div v-if="isSummary">
              {{res.summary | truncate(150, '...')}}
              <a v-if="res.summary.length> 150" @click="toggle()">Les mer</a>
            </div>
            <div v-else>
              {{ res.summary | truncate(1500, '...')}}
              <a @click="toggle()">Les mindre</a>
            </div>
             </b-card-text>
            <div slot="footer">
              <div>
                <font-awesome-icon icon="star" /> 
                {{ res.rating.average }}
                </div>
            </div>
            <small class="text-muted">
              </small>
          </b-card>
        </b-card-group>
        </div>
      </div>
    </div>
</template>


<script>
import api from '@/TvMazeApiService';

export default {
  name: 'Tvshows',
  data() {      
      return{
            results: [],
            isSummary: true
      }
  },
  async created(){
      this.results = await api.getAll();
  },
  methods:{
        toggle() {
        this.isSummary = !this.isSummary;
      }
  }
}
</script>

<style lang="scss">
</style>