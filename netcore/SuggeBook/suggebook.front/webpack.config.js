var webpack = require("webpack");
var ExtractTextPlugin = require("extract-text-webpack-plugin");

module.exports = {
    entry: "./src/home.js",
    output: {
        path: "suggebook.front/content",
        filename: "bundle.js",
        publicPath: "/content/"
    },
    module: {
        loaders: [
            {
                test: /\.js$/,
                exclude: /(node_modules)/,
                loader: 'babel-loader',
                query: {
                    presets: ["latest", "stage-2", "react"]
                }
            },
            {
                test: /\.css$/,
                loader: 'style-loader'
            },
            {
                test: /\.css$/,
                loader: combineLoaders([
                  {
                    loader: 'style-loader'
                  }, {
                    loader: 'css-loader',
                    query: {
                      modules: true,
                      localIdentName: '[name]__[local]___[hash:base64:5]'
                    }
                  }
                ])
              },
            {
    test: /\.scss$/,
        loader: ExtractTextPlugin.extract({
            fallback: 'style-loader',
            use: 'css-loader!autoprefixer-loader!sass-loader'
        })
},
{
    test: /\.(jpg|png)$/,
        loader: 'url-loader'
}
        ]
    },
plugins: [new ExtractTextPlugin("bundle.css")]
};