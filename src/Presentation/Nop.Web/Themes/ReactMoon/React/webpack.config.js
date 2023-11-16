const path = require("path")
const ManifestPlugin = require("webpack-manifest-plugin")

module.exports = {
    entry: {
        deps: path.resolve(__dirname, 'expose-components.ts'),
        searchbar: path.resolve(__dirname, 'components', 'search-bar.tsx'),
    },
    // entry: "./main.ts",
    resolve: {
        extensions: ['*', '.js', '.jsx', '.tsx', '.ts'],
    },
    output: {
        filename: '[name].bundle.js',
        globalObject: 'this',
        path: path.resolve(__dirname, '../../..', 'wwwroot/dist'),
        publicPath: '/dist/'
    },
    mode: process.env.NODE_ENV === 'production' ? 'production' : 'development',
    // mode: 'production',
    optimization: {
        runtimeChunk: {
            name: 'runtime', // necessary when using multiple entrypoints on the same page
        },
        splitChunks: {
            cacheGroups: {
                commons: {
                    test: /[\\/]node_modules[\\/](react|react-dom)[\\/]/,
                    name: 'vendor',
                    chunks: 'all',
                },
            },
        },
    },
    module: {
        rules: [
            {
                test: /\.(js|jsx|tsx|ts)$/,
                exclude: /node_modules/,
                use: [
                    {
                        loader: "babel-loader"
                    }
                ]
            },
            {
                test: /\.(css|scss)$/,
                use: [
                    {
                        loader: 'style-loader',
                    },
                    {
                        loader: 'css-loader',
                    },
                    {
                        loader: 'sass-loader',
                        options: {
                            sourceMap: true,
                        },
                    },
                    {
                        loader: "postcss-loader"
                    }
                ],
            },
        ],
    },
    plugins: [
        new ManifestPlugin.WebpackManifestPlugin({
            fileName: 'asset-manifest.json',
            generate: (seed, files) => {
                const manifestFiles = files.reduce((manifest, file) => {
                    manifest[file.name] = file.path;
                    return manifest;
                }, seed);

                const entrypointFiles = files.filter(x => x.isInitial && !x.name.endsWith('.map')).map(x => x.path);

                return {
                    files: manifestFiles,
                    entrypoints: entrypointFiles,
                };
            },
        }),
    ]
};